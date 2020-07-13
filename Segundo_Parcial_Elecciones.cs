using System;

namespace Segundo_Parcial_Elecciones
{
    class Program
    {
        public class Candidat
        {
            public string Candidato;
            public string Partidos;

            static void Main(string[] args)
            {
                string Persona; int Identificacion;
                Console.Title = "SISTEMA DE VOTACIONES";
                Console.WriteLine("BIENVENIDO A ESTE SISTEMA DE VOTACION");
                Console.WriteLine("Dijite Su Nombre Para Comenzar");
                Persona = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite 2 numeros para identificarte");
                Identificacion = int.Parse(Console.ReadLine());
                int confirmacion;


                Candidat candidato1 = new Candidat();
                candidato1.Candidato = "Juan isidro luperon";
                candidato1.Partidos = "Partido Nacional Dominicano (PND----12/Diciembre/2013) ";

                Candidat candidato2 = new Candidat();
                candidato2.Candidato = "Yoga Fernandez";
                candidato2.Partidos = "Partido cristiano (PC----12/Enero/2014) ";

                Candidat candidato3 = new Candidat();
                candidato3.Candidato = "Jessica Ogando";
                candidato3.Partidos = "Partido liberal azuanos (PLD----25/Noviembre/2015) ";

                Candidat candidato4 = new Candidat();
                candidato4.Candidato = "Gabriel Santana";
                candidato4.Partidos = "Partido De Programacion (PDP----15/Febrero/2016) ";


                Console.WriteLine("------------------------Listado de candidatos-------------------------");
                Console.WriteLine("Seleccione por el/la candidato(a) a votar para presidente(a):\n" +
                    "\n1.-" + candidato1.Candidato + candidato1.Partidos + candidato1 +
                    "\n2.-" + candidato2.Candidato + candidato2.Partidos + candidato2 +
                    "\n3.-" + candidato3.Candidato + candidato3.Partidos + candidato3 +
                    "\n4.-" + candidato4.Candidato + candidato4.Partidos + candidato4);

                int seleccion;
                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("¿Esta seguro(a) que desea dar su voto a este(a) candidato(a)?\n" +
                        "\n1.-Si" +
                        "\n2.-No");
                        confirmacion = int.Parse(Console.ReadLine());

                        if (confirmacion == 1)
                        {
                            Console.WriteLine("Gracias por su voto");
                            Console.WriteLine();
                            string[] candidatos =
                            {
                            "Partido: PND Partido Nacional Dominicano (PND----12/Diciembre/2013), Candidato:Juan isidro luperon, Aspira: presidencia " ,
                            "Partido: PC Partido cristiano (PC----12/Enero/2014), Candidato: Yoga Fernandez, Aspira: presidencia ",
                            "Partido: PLA Partido liberal azuanos (PLA----25/Noviembre/2015), Candidato: Jessica Ogando, Aspira: presidencia  " ,
                            "Partido: PRD Partido De La Programacion (PDS----15/Febrero/2016), Candidato: Gabriel Santana, Aspira: presidencia  "

                            };
                            Console.WriteLine(candidatos[0]);
                            Console.WriteLine(candidatos[1]);
                            Console.WriteLine(candidatos[2]);
                            Console.WriteLine(candidatos[3] + "\n");

                            int[] canvs = { 0, 0, 0, 0 };
                            double cand1, cand2, cand3, cand4, totald;

                            Random alear = new Random();

                            for (int a = 1; a < 1001; a++)
                            {
                                int be = alear.Next(1, 5);

                                if (be == 1)
                                {
                                    canvs[0] += 1;
                                }

                                if (be == 2)
                                {
                                    canvs[1] += 1;
                                }
                                if (be == 3)
                                {
                                    canvs[2] += 1;
                                }
                                if (be == 4)
                                {
                                    canvs[3] += 1;
                                }
                            }
                            totald = canvs[0] + canvs[1] + canvs[2] + canvs[3];

                            cand1 = (canvs[0] / totald) * 100;
                            cand2 = (canvs[1] / totald) * 100;
                            cand3 = (canvs[2] / totald) * 100;
                            cand4 = (canvs[3] / totald) * 100;

                            if (canvs[0] > canvs[1] && canvs[0] > canvs[2] && canvs[0] > canvs[3])
                            {
                                Console.WriteLine("El ganador es  Juan isidro luperon \n");
                            }
                            if (canvs[1] > canvs[0] && canvs[1] > canvs[2] && canvs[1] > canvs[3])
                            {
                                Console.WriteLine("El ganador es  Yoga Fernandez \n");
                            }
                            if (canvs[2] > canvs[1] && canvs[2] > canvs[0] && canvs[2] > canvs[3])
                            {
                                Console.WriteLine("El ganador es  Jessica Ogando \n");
                            }
                            if (canvs[3] > canvs[1] && canvs[3] > canvs[2] && canvs[3] > canvs[0])
                            {
                                Console.WriteLine("El ganador es Gabriel Santana \n");
                            }

                            Console.WriteLine("Juan tuvo un " + cand1 + "% de votos" + "\n" + "Yoga tuvo un " + cand2 + "% de votos" + "\n" + "Jessica tuvo un " + cand3 + "% de votos" + "\n" + "Gabriel tuvo un " + cand4 + "% de votos \n");

                            Console.WriteLine("Orden de mayor a menor de los votos\n");
                            for (int i = 0; i < canvs.Length; i++)
                            {
                                for (int j = i + 1; j < canvs.Length; j++)
                                {
                                    int ayu;
                                    if (canvs[i] > canvs[j])
                                    {
                                        ayu = canvs[i];
                                        canvs[i] = canvs[j];
                                        canvs[j] = ayu;
                                    }
                                }

                            }
                            for (int i = 3; i >= 0; i--)
                            {
                                Console.WriteLine(canvs[i]);
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Gracias por su tiempo");
                        }

                        break;

                    case 2:
                        Console.WriteLine("¿Esta seguro(a) que desea dar su voto a este(a) candidato(a)?\n" +
                        "\n1.-Si" +
                        "\n2.-No");
                        confirmacion = int.Parse(Console.ReadLine());

                        if (confirmacion == 1)
                        {
                            Console.WriteLine("Gracias por su voto");
                            Console.WriteLine();
                            string[] candidatos =
                            {
                            "Partido: PND Partido Nacional Dominicano (PND----12/Diciembre/2013), Candidato:Juan isidro luperon, Aspira: presidencia " ,
                            "Partido: PC Partido cristiano (PC----12/Enero/2014), Candidato: Yoga Fernandez, Aspira: presidencia ",
                            "Partido: PLA Partido liberal azuanos (PLA----25/Noviembre/2015), Candidato: Jessica Ogando, Aspira: presidencia  " ,
                            "Partido: PRD Partido De La Programacion (PDS----15/Febrero/2016), Candidato: Gabriel Santana, Aspira: presidencia  "

                            };
                            Console.WriteLine(candidatos[0]);
                            Console.WriteLine(candidatos[1]);
                            Console.WriteLine(candidatos[2]);
                            Console.WriteLine(candidatos[3] + "\n");

                            int[] canvs = { 0, 0, 0, 0 };
                            double cand1, cand2, cand3, cand4, totald;

                            Random alear = new Random();

                            for (int a = 1; a < 1001; a++)
                            {
                                int be = alear.Next(1, 5);

                                if (be == 1)
                                {
                                    canvs[0] += 1;
                                }

                                if (be == 2)
                                {
                                    canvs[1] += 1;
                                }
                                if (be == 3)
                                {
                                    canvs[2] += 1;
                                }
                                if (be == 4)
                                {
                                    canvs[3] += 1;
                                }
                            }
                            totald = canvs[0] + canvs[1] + canvs[2] + canvs[3];

                            cand1 = (canvs[0] / totald) * 100;
                            cand2 = (canvs[1] / totald) * 100;
                            cand3 = (canvs[2] / totald) * 100;
                            cand4 = (canvs[3] / totald) * 100;

                            if (canvs[0] > canvs[1] && canvs[0] > canvs[2] && canvs[0] > canvs[3])
                            {
                                Console.WriteLine("El ganador es  Juan isidro luperon \n");
                            }
                            if (canvs[1] > canvs[0] && canvs[1] > canvs[2] && canvs[1] > canvs[3])
                            {
                                Console.WriteLine("El ganador es  Yoga Fernandez \n");
                            }
                            if (canvs[2] > canvs[1] && canvs[2] > canvs[0] && canvs[2] > canvs[3])
                            {
                                Console.WriteLine("El ganador es  Jessica Ogando \n");
                            }
                            if (canvs[3] > canvs[1] && canvs[3] > canvs[2] && canvs[3] > canvs[0])
                            {
                                Console.WriteLine("El ganador es Gabriel Santana \n");
                            }

                            Console.WriteLine("Juan tuvo un " + cand1 + "% de votos" + "\n" + "Yoga tuvo un " + cand2 + "% de votos" + "\n" + "Jessica tuvo un " + cand3 + "% de votos" + "\n" + "Gabriel tuvo un " + cand4 + "% de votos \n");

                            Console.WriteLine("Orden de mayor a menor de los votos\n");
                            for (int i = 0; i < canvs.Length; i++)
                            {
                                for (int j = i + 1; j < canvs.Length; j++)
                                {
                                    int ayu;
                                    if (canvs[i] > canvs[j])
                                    {
                                        ayu = canvs[i];
                                        canvs[i] = canvs[j];
                                        canvs[j] = ayu;
                                    }
                                }

                            }
                            for (int i = 3; i >= 0; i--)
                            {
                                Console.WriteLine(canvs[i]);
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Gracias por su tiempo");
                        }

                        break;

                    case 3:
                        Console.WriteLine("¿Esta seguro(a) que desea dar su voto a este(a) candidato(a)?\n" +
                        "\n1.-Si" +
                        "\n2.-No");
                        confirmacion = int.Parse(Console.ReadLine());

                        if (confirmacion == 1)
                        {
                            Console.WriteLine("Gracias por su voto");
                            Console.WriteLine();
                            string[] candidatos =
                            {
                            "Partido: PND Partido Nacional Dominicano (PND----12/Diciembre/2013), Candidato:Juan isidro luperon, Aspira: presidencia " ,
                            "Partido: PC Partido cristiano (PC----12/Enero/2014), Candidato: Yoga Fernandez, Aspira: presidencia ",
                            "Partido: PLA Partido liberal azuanos (PLA----25/Noviembre/2015), Candidato: Jessica Ogando, Aspira: presidencia  " ,
                            "Partido: PRD Partido De La Programacion (PDS----15/Febrero/2016), Candidato: Gabriel Santana, Aspira: presidencia  "

                            };
                            Console.WriteLine(candidatos[0]);
                            Console.WriteLine(candidatos[1]);
                            Console.WriteLine(candidatos[2]);
                            Console.WriteLine(candidatos[3] + "\n");

                            int[] canvs = { 0, 0, 0, 0 };
                            double cand1, cand2, cand3, cand4, totald;

                            Random alear = new Random();

                            for (int a = 1; a < 1001; a++)
                            {
                                int be = alear.Next(1, 5);

                                if (be == 1)
                                {
                                    canvs[0] += 1;
                                }

                                if (be == 2)
                                {
                                    canvs[1] += 1;
                                }
                                if (be == 3)
                                {
                                    canvs[2] += 1;
                                }
                                if (be == 4)
                                {
                                    canvs[3] += 1;
                                }
                            }
                            totald = canvs[0] + canvs[1] + canvs[2] + canvs[3];

                            cand1 = (canvs[0] / totald) * 100;
                            cand2 = (canvs[1] / totald) * 100;
                            cand3 = (canvs[2] / totald) * 100;
                            cand4 = (canvs[3] / totald) * 100;

                            if (canvs[0] > canvs[1] && canvs[0] > canvs[2] && canvs[0] > canvs[3])
                            {
                                Console.WriteLine("El ganador es  Juan isidro luperon \n");
                            }
                            if (canvs[1] > canvs[0] && canvs[1] > canvs[2] && canvs[1] > canvs[3])
                            {
                                Console.WriteLine("El ganador es  Yoga Fernandez \n");
                            }
                            if (canvs[2] > canvs[1] && canvs[2] > canvs[0] && canvs[2] > canvs[3])
                            {
                                Console.WriteLine("El ganador es  Jessica Ogando \n");
                            }
                            if (canvs[3] > canvs[1] && canvs[3] > canvs[2] && canvs[3] > canvs[0])
                            {
                                Console.WriteLine("El ganador es Gabriel Santana \n");
                            }

                            Console.WriteLine("Juan tuvo un " + cand1 + "% de votos" + "\n" + "Yoga tuvo un " + cand2 + "% de votos" + "\n" + "Jessica tuvo un " + cand3 + "% de votos" + "\n" + "Gabriel tuvo un " + cand4 + "% de votos \n");

                            Console.WriteLine("Orden de mayor a menor de los votos\n");
                            for (int i = 0; i < canvs.Length; i++)
                            {
                                for (int j = i + 1; j < canvs.Length; j++)
                                {
                                    int ayu;
                                    if (canvs[i] > canvs[j])
                                    {
                                        ayu = canvs[i];
                                        canvs[i] = canvs[j];
                                        canvs[j] = ayu;
                                    }
                                }

                            }
                            for (int i = 3; i >= 0; i--)
                            {
                                Console.WriteLine(canvs[i]);
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Gracias por su tiempo");
                        }

                        break;

                    case 4:
                        Console.WriteLine("¿Esta seguro(a) que desea dar su voto a este(a) candidato(a)?\n" +
                        "\n1.-Si" +
                        "\n2.-No");
                        confirmacion = int.Parse(Console.ReadLine());

                        if (confirmacion == 1)
                        {
                            Console.WriteLine("Gracias por su voto");
                            Console.WriteLine();
                            string[] candidatos =
                            {
                            "Partido: PND Partido Nacional Dominicano (PND----12/Diciembre/2013), Candidato:Juan isidro luperon, Aspira: presidencia " ,
                            "Partido: PC Partido cristiano (PC----12/Enero/2014), Candidato: Yoga Fernandez, Aspira: presidencia ",
                            "Partido: PLA Partido liberal azuanos (PLA----25/Noviembre/2015), Candidato: Jessica Ogando, Aspira: presidencia  " ,
                            "Partido: PRD Partido De La Programacion (PDS----15/Febrero/2016), Candidato: Gabriel Santana, Aspira: presidencia  "

                            };
                            Console.WriteLine(candidatos[0]);
                            Console.WriteLine(candidatos[1]);
                            Console.WriteLine(candidatos[2]);
                            Console.WriteLine(candidatos[3] + "\n");

                            int[] canvs = { 0, 0, 0, 0 };
                            double cand1, cand2, cand3, cand4, totald;

                            Random alear = new Random();

                            for (int a = 1; a < 1001; a++)
                            {
                                int be = alear.Next(1, 5);

                                if (be == 1)
                                {
                                    canvs[0] += 1;
                                }

                                if (be == 2)
                                {
                                    canvs[1] += 1;
                                }
                                if (be == 3)
                                {
                                    canvs[2] += 1;
                                }
                                if (be == 4)
                                {
                                    canvs[3] += 1;
                                }
                            }
                            totald = canvs[0] + canvs[1] + canvs[2] + canvs[3];

                            cand1 = (canvs[0] / totald) * 100;
                            cand2 = (canvs[1] / totald) * 100;
                            cand3 = (canvs[2] / totald) * 100;
                            cand4 = (canvs[3] / totald) * 100;

                            if (canvs[0] > canvs[1] && canvs[0] > canvs[2] && canvs[0] > canvs[3])
                            {
                                Console.WriteLine("El ganador es  Juan isidro luperon \n");
                            }
                            if (canvs[1] > canvs[0] && canvs[1] > canvs[2] && canvs[1] > canvs[3])
                            {
                                Console.WriteLine("El ganador es  Yoga Fernandez \n");
                            }
                            if (canvs[2] > canvs[1] && canvs[2] > canvs[0] && canvs[2] > canvs[3])
                            {
                                Console.WriteLine("El ganador es  Jessica Ogando \n");
                            }
                            if (canvs[3] > canvs[1] && canvs[3] > canvs[2] && canvs[3] > canvs[0])
                            {
                                Console.WriteLine("El ganador es Gabriel Santana \n");
                            }

                            Console.WriteLine("Juan tuvo un " + cand1 + "% de votos" + "\n" + "Yoga tuvo un " + cand2 + "% de votos" + "\n" + "Jessica tuvo un " + cand3 + "% de votos" + "\n" + "Gabriel tuvo un " + cand4 + "% de votos \n");

                            Console.WriteLine("Orden de mayor a menor de los votos\n");
                            for (int i = 0; i < canvs.Length; i++)
                            {
                                for (int j = i + 1; j < canvs.Length; j++)
                                {
                                    int ayu;
                                    if (canvs[i] > canvs[j])
                                    {
                                        ayu = canvs[i];
                                        canvs[i] = canvs[j];
                                        canvs[j] = ayu;
                                    }
                                }

                            }
                            for (int i = 3; i >= 0; i--)
                            {
                                Console.WriteLine(canvs[i]);
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Gracias por su tiempo");
                        }

                        break;

                    default:
                        break;
                }

            }
        }
    }
}