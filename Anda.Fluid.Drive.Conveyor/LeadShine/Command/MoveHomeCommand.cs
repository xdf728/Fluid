﻿using Anda.Fluid.Drive.Conveyor.LeadShine.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anda.Fluid.Drive.Conveyor.LeadShine.Command
{
    internal class MoveHomeCommand : MotionCommand
    {
        private int axisNo, startVel, maxVel;
        private double accTime;
        public MoveHomeCommand(int axisNo,int startVel,int maxVel,double accTime)
        {
            this.axisNo = axisNo;
            this.startVel = startVel;
            this.maxVel = maxVel;
            this.accTime = accTime;
        }
        public override void Run()
        {
            int result = csDmc1000.Dmc1000.d1000_home_move(this.axisNo, this.startVel, this.maxVel, this.accTime);
            if (result != 0)
            {
                this.State = CommmandState.Failed;
            }
            else
            {
                this.State = CommmandState.Running;
            }
        }

        public override void UpdateState()
        {
            int axisState = csDmc1000.Dmc1000.d1000_check_done(this.axisNo);
            if (axisState == 4 || axisState == 3)
            {
                if (InPutMgr.Instance.AxisYInput.OrgSts == IOSts.High)
                {
                    this.State = CommmandState.Succeed;
                    this.AutoEvent.Set();
                }

            }
            else if (axisState == 2)
            {
                this.State = CommmandState.Abort;
            }
        }
    }
}
