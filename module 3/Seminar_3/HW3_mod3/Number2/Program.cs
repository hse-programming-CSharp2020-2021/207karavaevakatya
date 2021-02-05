using System;

namespace Number5 
{
    class VetoEventArgs: EventArgs
    {
        public string  Proposal { get; set; }
        public VetoVoter VetoBy { get; set; } = null;
    }
    class VetoComission
    {
        public event EventHandler<VetoEventArgs> OnVote;

        public VetoEventArgs Vote(string Proposal)
        {
            VetoEventArgs vetoEventArgs = new VetoEventArgs();
            Console.WriteLine(Proposal);
            vetoEventArgs.Proposal = Proposal;
            OnVote?.Invoke(this, vetoEventArgs);
            return vetoEventArgs;
        }
    }

    class VetoVoter
    {
        Random rnd = new Random();
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                Name = value;
            }
        }

        public VetoVoter(string name)
        {
            Name = name;
        }

        public void Vote(object sender, VetoEventArgs args)
        {
            if (rnd.Next(5) == 1 && args.VetoBy == null)
                args.VetoBy = this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string proposal = "???";
            VetoComission comission = new VetoComission();
            VetoVoter[] voters = new VetoVoter[n];
            for (int i = 0; i < n; i++)
            {
                voters[i] = new VetoVoter($"Voter- {i + 1}");
                comission.OnVote += voters[i].Vote;
            }
            VetoEventArgs result = comission.Vote(proposal);
            if (result.VetoBy != null)
                Console.WriteLine($"Veto - {result.VetoBy.Name}");
            else
                Console.WriteLine("No veto");
        }
    }
}