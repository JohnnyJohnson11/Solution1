//testing sean

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL_WorkersUnion
{
    
    internal class StatusPekerja
    {
        private State currentState;
        public StatusPekerja()
        {
            currentState = State.unemployed;
        }
        public void ProcessChar(List<Lamaran> lamaranDikirim)
        {
            int num=0;
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
                        checkStatus();
                        break;
                    } else
                    {
                        for (int i = 0; i < lamaranDikirim.Count && lamaranDikirim[i].statusLamaran != "pending"; i++)
                        {
                            num = i;
                        }
                        if (lamaranDikirim[num].statusLamaran == "pending")
                        {
                            currentState=State.searching;
                            checkStatus();
                            break;
                        }
                        else
                        {
                            currentState = State.unemployed;
                            checkStatus();
                            break;
                        }
                    }
                case State.searching:
                    for (int i = 0; i < lamaranDikirim.Count && lamaranDikirim[i].statusLamaran != "diterima"; i++)
                    {
                        num = i;
                    }
                    if (lamaranDikirim[num].statusLamaran == "diterima")
                    {
                        currentState = State.employed;
                        checkStatus();
                        break;
                    }
                    checkStatus();
                    break;
            }
        }
        public void checkStatus()
        {
            if (currentState == State.employed)
            {
                Console.WriteLine("Pekerja sudah diterima");
            } else if (currentState == State.searching)
            {
                Console.WriteLine("Pekerja masih mencari pekerjaan");
            } else if (currentState == State.unemployed)
            {
                Console.WriteLine("Tidak sedang mencari pekerjaan");
            } else
            {
                Console.WriteLine();
            }
        }

    }
}
