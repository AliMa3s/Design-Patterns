using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerBuilder
{
    public class ComputerConfigurator {
        public void BouwVolledigeComputer(ComputerBouwer computer) {
            computer.StartBouwPc();
            computer.VoegProcessorToe();
            computer.VoegGrafischeKaartToe();
            computer.VoegGeheugenToe();
            computer.VoegVoedingToe();
            computer.StopBouwPc();
        }
        public void BouwComputerZonderGeheugen(ComputerBouwer computer) {
            computer.StartBouwPc();
            computer.VoegProcessorToe();
            computer.VoegGrafischeKaartToe();
            computer.VoegVoedingToe();
            computer.StopBouwPc();
        }
    }
}
