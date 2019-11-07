using System;

namespace Codenation.Challenge
{
    public class Country
    {        
        public State[] Top10StatesByArea()
        {
            State AM = new State("Amazonas", "AM");
            State PA = new State("Pará", "PA");
            State MT = new State("Mato Grosso", "MT");
            State MG = new State("Minas Gerais", "MG");
            State BA = new State("Bahia", "BA");
            State MS = new State("Mato Grosso do Sul", "MS");
            State GO = new State("Goiás", "GO");
            State MA = new State("Maranhão", "MA");
            State RS = new State("Rio Grande do Sul", "RS");
            State TO = new State("Tocantins", "TO");

            State[] states = new State[10];
            states[0] = AM;
            states[1] = PA;
            states[2] = MT;
            states[3] = MG;
            states[4] = BA;
            states[5] = MS;
            states[6] = GO;
            states[7] = MA;
            states[8] = RS;
            states[9] = TO;

            return states;
        }
    }
}
