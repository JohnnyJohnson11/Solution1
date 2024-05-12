using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL_WorkersUnion
{
    public enum State { unemployed, searching, employed}
    internal class StatusPekerja
    {
        private State currentState;
        public StatusPekerja()
        {
            currentState = State.unemployed;
        }
        public void ProcessChar(List<Lamaran> lamaranDikirim)
        {
            int num;
            switch (currentState)
            {
                case State.unemployed:
                    for (int i = 0;i < lamaranDikirim.Count && lamaranDikirim[i].statusLamaran!="diterima";i++)
                    {
                        num = i;
                    }
                    if (lamaranDikirim[num].statusLamaran == "diterima")
                    {
                        currentState=State.employed;
                    } else
                    {
                        for (int i = 0; i < lamaranDikirim.Count && lamaranDikirim[i].statusLamaran != "pending"; i++)
                        {
                            num = i;
                        }
                        if (lamaranDikirim[num].statusLamaran == "pending")
                        {
                            currentState=State.searching;
                        }
                        else
                        {
                            currentState = State.unemployed;
                        }
                    }
                    break;
                case State.searching:
                    for (int i = 0; i < lamaranDikirim.Count && lamaranDikirim[i].statusLamaran != "diterima"; i++)
                    {
                        num = i;
                    }
                    if (lamaranDikirim[num].statusLamaran == "diterima")
                    {
                        currentState = State.employed;
                    }
                    else
                    {
                        for (int i = 0; i < lamaranDikirim.Count && lamaranDikirim[i].statusLamaran != "pending"; i++)
                        {
                            num = i;
                        }
                        if (lamaranDikirim[num].statusLamaran == "pending")
                        {
                            currentState = State.searching;
                        }
                        else
                        {
                            currentState = State.unemployed;
                        }
                    }
                    break;
            }
        }
        public string IsAccepted()
        {
            if (currentState == State.employed)
            {
                return "Pekerja sudah diterima";
            } else if (currentState == State.searching)
            {
                return "Pekerja masih mencari pekerjaan";
            } else if (currentState == State.unemployed)
            {
                return "Tidak sedang mencari pekerjaan";
            } else
            {
                return "";
            }
        }

    }
}
