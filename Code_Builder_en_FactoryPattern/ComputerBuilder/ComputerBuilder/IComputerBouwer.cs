using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerBuilder
{
    public interface IComputerBouwer
    {
        void StartBouwPc();
        void VoegVoedingToe();
        void VoegProcessorToe();
        void VoegGrafischeKaartToe();
        void VoegGeheugenToe();
        void StopBouwPc();
        Computer GetPc();
    }
}
