using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21_MusicRadio
{
    public interface IRadioPlayerInterface
    {
        void retune(double frequency);
        void changeChannel();
    }
}
