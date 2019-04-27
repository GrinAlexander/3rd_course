using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_WPF
{
    enum Type
    {

    }
    class Multivarka
    {
        string type;
        int amount;
        int power;
        string color;
        string material;
        string heating;
        int countProgramms;
        string program;
        string childProgram;
        string evenHeating;
        string heatingType;
        string settingDeg;
        string handlingType;
        string settingTime;
        string startDelay;
        string voiceGuide;
        string display;
        string displayType;

        public Multivarka(string type,
            int amount,
            int power,
            string color,
            string material,
            string heating,
         int countProgramms,
        string program,
        string childProgram,
        string evenHeating,
        string heatingType,
        string settingDeg,
        string handlingType,
        string settingTime,
        string startDelay,
        string voiceGuide,
        string display,
        string displayType)
        {
                this.type = type;
                this.amount = amount;
                this.power = power;
                this.color = color;
                this.material = material;
                this.heating = heating;
                this.countProgramms = countProgramms;
                this.program = program;
                this.childProgram = childProgram;
                this.evenHeating = evenHeating;
                this.heatingType = heatingType;
                this.settingDeg = settingDeg;
                this.handlingType = handlingType;
                this.settingTime = settingTime;
                this.startDelay = startDelay;
                this.voiceGuide = voiceGuide;
                this.display = display;
                this.display = displayType;         
        }

    }
}

