using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Olio-ohjelmonnin viikkotehtävät Labra1
//Lassi Markkola
namespace Labrat
{
    public class Kiuas
    {

        public static void Tehtava01()
        {
            //Tehtävänäsi on ohjelmoida kiukaan toiminta. Kiuas pitää pystyä laittamaan päälle ja pois, sekä sen lämpötilaa että sen antamaa kosteutta pitää pystyä säätämään (arvoja ei ole rajattu).

            // field variables

        }
        // properties
        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public double Temperature
        {
            get; set;
        }

        public double Moisture
        {
            get; set;
        }

        // constructors
        // methods
        public void HeatUp()
        {
            Temperature += 10;
        }
        public void HeatDown()
        {
            Temperature -= 10;
        }

        public void MoistureUp()
        {
            Moisture += 5;
        }
        public void MoistureDown()
        {
            Moisture -= 5;
        }

        public void StateUp()
        {
            State = "On";
        }
        public void StateOff()
        {
            State = "Off";
            Temperature = 0;
            Moisture = 0;
        }

        //Pääohjelma
        public static void main()
        {
            Kiuas kiuas = new Kiuas();
            kiuas.Temperature = 0;
            kiuas.Moisture = 0;
            kiuas.State = "Off";

            Console.WriteLine("State: {0}", kiuas.state);
            Console.WriteLine("Temperature: {0}", kiuas.Temperature);
            Console.WriteLine("Moisture: {0}", kiuas.Moisture);
            Console.WriteLine(" ");

            Console.WriteLine("Set state (On/Off) :");
            kiuas.State = (Console.ReadLine());
            Console.WriteLine("Set temperature ('C) :");
            kiuas.Temperature = int.Parse(Console.ReadLine());
            Console.WriteLine("Set moisture (%):");
            kiuas.Moisture = int.Parse(Console.ReadLine());

            Console.WriteLine("State: {0}", kiuas.state);
            Console.WriteLine("Temperature: {0}'C", kiuas.Temperature);
            Console.WriteLine("Moisture: {0} %", kiuas.Moisture);

        }

    }

    //UML-kaavio
    //https://www.draw.io/?lightbox=1&highlight=0000ff&edit=_blank&layers=1&nav=1&title=Kiuas.xml#R7VbRbpswFP0apO1hE4YmTR8b0q4PiVotnfrsggGrxhcZp0n69bvGdgghWbNW2tMiFNnH59rce861COKk2vxQtC4XkDERRGG2CeJZEEUXozH%2BG2BrgctoZIFC8cxCpAOW%2FI05MHToimes6RE1gNC87oMpSMlS3cOoUrDu03IQ%2FVNrWrABsEypGKJPPNOlRSfRuMPvGC9KfzIZX9mVZ5q%2BFApW0p0XRHHe%2FuxyRf1eLtGmpBms96D4JogTBaDtqNokTJjS%2BrLZuNsTq7v3VkzqcwIubcArFSuXeiJo00haMfeCeuuL0qx5JajE2TQHqZduheCcCl5IHKd4LFMIvDKlOdbz2i1oqBFNSy6yOd3Cyrxco7FYfjYtQfE33JYKtycuK%2B2sEU16jKWJRDhEVLEGOQ8%2BY3IALeimR5zTRjsgBSFo3fDnXRoVVQWXU9AaKkfySd9yIRIQoNpaeFHjqasfpss2JzUgO2WxYRhUTKstUlxAFDozuGYhV26%2B7qxHxg4r92wXeZA6uxe7vTvJceBUP%2B6AycABQYRZhVhjjcB16wHFZREY98ckbJPeGxryI6tqpqheKReSwcqU9Q8hC%2BDNkH9gOSyqbq2g4IX58kuwHtxTxEHehoLl%2BqQJm5qmmM685cwuOuSnq6yBAGNz0XZmybOMSWMgwJJQ6xaTRw1c6rbyoyk%2BqEUSfh8FI3zxBOekm%2BNj6EonIDEXyltjMLTimhk7nueiy%2BMucq7xQr5nmkn0ec9cHfHMgXKCt4pY5fwdSj4kW4UCCNbp9GhknH0jAy3joZbxEd0EfWbiARquOZj9leUe6PkPJCPkzEaffF4yf9Sgz%2B8lht7n%2BZevbSeebtg7Rn%2FV57D0DNbyXaLv%2FzP29NS9ff%2FfEx833ZkXBbn4%2B5sCp923S7u2930Y3%2FwG


    public class Pesukone
    {
        //Tehtävänäsi on ohjelmoida pesukoneen toiminta. Samoin kuin edellinen tehtävä: mitä ominaisuuksia ja toimintoja tekisit Pesukone-luokkaan?
        // properties
        private string hatch;
        public string Hatch
        {
            get { return hatch; }
            set { hatch = value; }
        }

        public double Time
        {
            get; set;
        }

        public string Type
        {
            get; set;
        }

        // constructors
        public Pesukone()
        {
        
        }
        public Pesukone(string Hatch)
        {
            Hatch = "Closed";
        }
        public Pesukone(string Hatch, string Type)
        {
            Hatch = "Closed";
            Type = "N/A";
        }
        public Pesukone(string Hatch, string Type, int Time)
        {
            Hatch = "Closed";
            Type = "N/A";
            Time = 0;
        }

        // methods
        public void HatchOpen()
        {
            Hatch = "Open";
        }
        public void HatchClose()
        {
            Hatch = "Closed";
        }


        public void SetType1()
        {
            Type = "Kirjopesu";
        }
        public void SetType2()
        {
            Type = "Valkopesu";
        }
        public void SetType3()
        {
            Type = "Sekapesu";
        }


        public void TimeUp()
        {
            Time += 10;
        }
        public void TimeDown()
        {
            Time -= 10;
        }

        //Pääohjelma
        public static void main()
        {
            Pesukone kone = new Pesukone();
            kone.Hatch = "Closed";
            kone.Type = "N/A";
            kone.Time = 0;

            Console.WriteLine("Hatch: {0}", kone.Hatch);
            Console.WriteLine("Type: {0}", kone.Type);
            Console.WriteLine("Time: {0}m", kone.Time);
            Console.WriteLine(" ");
        }

        //UML-kaavio
        //https://www.draw.io/?lightbox=1&highlight=0000ff&edit=_blank&layers=1&nav=1&title=Pesukone.xml#R7VbLbtswEPwaAe2hhR6x4xxjOY9DggZ1ip4ZaS0RobgCRcd2vr5LirQk20HUBOiphmCIs0Nyd2dIKEjSanujWF3eYw4iiMN8GySLII7PJlP6N8CuBabnDigUz1so6oAlfwUHhg5d8xyaAVEjCs3rIZihlJDpAcaUws2QtkIx3LVmBRwBy4yJY%2FQ3z3XZorN42uG3wIvS7xxNL9rIE8ueC4Vr6fYL4mRlf224Yn4tV2hTshw3PSi5CpJUIer2rdqmIExrfdvaeddvRPd5K5B6zITzdsILE2tX%2BgM062eU4PLTO9%2BTZsMrwSiQzFco9dJFIhozwQtJ7xntCoqAF1CaUzsvXUBjTWhWcpHfsR2uTW6Npl750bxExV9pWSbcmhRW2jkjng0YSzOT4JBQBQ1xHnzB0QF0z7YD4h1rtAMyFILVDX%2Fal1ExVXA5R62xciRf9DUXIkWByvbCa5rMj%2FvtJDAdgG0Pcv2%2FAaxAqx1RXDQOnRfcWYku3HjTOS%2BaOqzsuS7xJmLO7cV%2B7U5xenGinzbA7MgAQUxVhbdMZ7T5pfWA4rIIjPmTKLRF914N%2BXFXw1iu5pXjcmpZP3rgN2qftj5Q%2BAy%2B9xJbA%2FbkcJD3oICVftOBTc0yyu%2FOchZnHfLTtdVASHNXwp7Kkuc5SOMe1Eyz1iom2xope9v2yZweEiINv0%2BCCSWe0jjqxvQYutIpSqqFcWsUIB9uwHjxhIXOR1vIWcar%2BJ5jZvHnDXNxwjAHygluFWmV8%2Fdn9CHZKhJAQKfTo5Fx8S060jI51jI5oZtgTyAesOGao1lftdwDPf%2BBZFE08pTPPi%2BZ3%2Br0If9Rg%2Fzy1R7Jt0%2BtZaYCG3iXugRt7oNoLDEeS0zeJT7S3fKrHkVb4MZX%2Ff%2Fe%2BbiJR148cfj3Nw8Nu%2B8gG%2Bt9ayZXfwA%3D

    }

    public class TV
    {
        //Tehtävänäsi on ohjelmoida television toiminta. Samoin kuin edellinen tehtävä: mitä ominaisuuksia ja toimintoja tekisit Televisio-luokkaan?

        // field variables        
        // properties
        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public double Channel
        {
            get; set;
        }

        public double Volume
        {
            get; set;
        }

        // constructors
        // methods
        public void ChannelUp()
        {
            Channel += 1;
        }
        public void ChannelDown()
        {
            Channel -= 1;
        }

        public void VolumeUp()
        {
            Volume += 1;
        }
        public void VolumeDown()
        {
            Volume -= 1;
        }

        public void StateOn()
        {
            State = "On";
        }
        public void StateOff()
        {
            State = "Off";
        }

        //Pääohjelma
        public static void main()
        {
            TV televisio = new TV();
            televisio.Channel= 0;
            televisio.Volume = 0;
            televisio.State = "Off";

            Console.WriteLine("State: {0}", televisio.state);
            Console.WriteLine("Channel: {0}", televisio.Channel);
            Console.WriteLine("Volume: {0}", televisio.Volume);
            Console.WriteLine(" ");

            Console.WriteLine("Set state (On/Off) :");
            televisio.State = (Console.ReadLine());
            Console.WriteLine("Set channel :");
            televisio.Channel = int.Parse(Console.ReadLine());
            Console.WriteLine("Set volume :");
            televisio.Volume = int.Parse(Console.ReadLine());

            Console.WriteLine("State: {0}", televisio.state);
            Console.WriteLine("Channel: {0}", televisio.Channel);
            Console.WriteLine("Volume: {0}", televisio.Volume);
            Console.WriteLine(" ");

        }

        //UML-kaavio
        //https://www.draw.io/?lightbox=1&highlight=0000ff&edit=_blank&layers=1&nav=1&title=TV.xml#R7VZdb9sgFP01lraHTcZu8%2FHYOG33kGrV0rXP1MY2KuZamDRJf%2F0uBmI7Sduslfa0yFLgcADfcw7IQZxUm2tF6%2FIGMiaCKMw2QTwPooicRSP8M8jWIqOpAwrFM0fqgCV%2FYQ4MHbriGWsGRA0gNK%2BHYApSslQPMKoUrIe0HMRw15oW7ABYplQcog8806VFJ74sg%2F9gvCj9zmQ0tSOPNH0qFKyk2y%2BI4rz92eGK%2BrVcoU1JM1j3oPgyiBMFoG2r2iRMGG29bHbe1Suju%2FdWTOpTJozthGcqVq70u3v3Znrr1WjWvBJUYm%2BWg9RLN0KwTwUvJLZT3I8pBJ6Z0hyFvHADGmpE05KLbEG3sDJv1WhUyfdmJSj%2BgstS4dbEYaVdJqLJgLE0MxEOEVWsQc6tL5XsQTd0MyAuaKMdkIIQtG74466MiqqCyxloDZUj%2BaKvuBAJCFCtFt7NeHaotBPfKMA2Pcgpf82gYlptkeJGo9ClwJ0SMnX9dZc5MnJY2ctb5InU5bzYrd15jQ1n93HrJwfWBxFWFaLGGoGLNgOKyyIwsY9J2BbdaxpyUlI8gcLSM1gZSd%2Bg34NYVWzI3gsbaqfbECh4Yl54CTZ9PS8c5AMoWK5fjV9T0xQLWbSc%2BVmH%2FHKaGghwbi7aw1jyLGPSRAdQDGpzYqqogUvdan4%2BwwddSMLv58E5vniCfdL18TF0pROQWAvlbUoYhnDNTBCP5Gd8cn5cXryF78VlEn0%2BLdMjadlzTvDWEeucvzbJh2yr0ADBOp%2FujI3zb%2BTAy%2FjQy%2FiIb4I%2BMnELDdcczPrKcvf8%2FAeWEXLiEZ983jK%2F1fET%2FlN%2B%2BdoexFdOqyXl%2Bdus7gr4XZ%2FKnMP6nb13N8UJi1pib83%2F98nHw3nihULGf3%2BjYLf7rGnHet%2BO8eUf
    }
}

