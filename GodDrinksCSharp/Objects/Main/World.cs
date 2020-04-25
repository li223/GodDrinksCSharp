using System;
using System.Collections.Generic;
using System.Linq;

namespace GodDrinksCSharp.Objects
{
    public class World
    {
        public (string, uint) TimePeriod { get; set; }
        public List<Thing> Things { get; set; }
        public World(int instances)
        {
            this.Things = new List<Thing>(instances);
            this.TimePeriod = ("AC", (uint)DateTime.Now.Year);
        }

        public void AddThing(Thing thing) => this.Things.Add(thing);
        public Simulation StartSimulation() => new Simulation();
        public void TimeTravelForTwo(string period, uint year, Thing object_one, Thing object_two)
        {
            this.TimePeriod = (period, year);
            object_one.TimePeriod = this.TimePeriod;
            object_two.TimePeriod = this.TimePeriod;
        }
        public Thing Unite(Thing object_one, Thing object_two)
        {
            var newthing = new Thing();
            object_one.Actions.ToList().ForEach(x => newthing.Actions.Add(x.Key, x.Value));
            object_two.Actions.ToList().ForEach(x => newthing.Actions.Add(x.Key, x.Value));
            object_one.Attributes.AddRange(object_two.Attributes);
            newthing.Attributes.AddRange(object_one.Attributes);
            return newthing;
        }
        public void LockThing(Thing obj) => obj.IsLocked = true;
        public Thing GetGod() => new Thing();
        public void Procreate(Thing obj_one, Thing obj_two) => new Thing();
        public void MakeHigh(Thing obj) => obj.IsHigh = true;
        public void Unlock(Thing obj) => obj.IsLocked = false;
        public void RemoveThing(Thing obj) => this.Things.Remove(obj);
        public void Announce(string message) => Console.WriteLine($"World Announces: {message}");
        public void Announce(string message, string language) => Console.WriteLine($"World Announces: {message} in {language}");
        public void RunExecution() => Console.WriteLine("Running Execution");
        public bool IsExecutableBy(Thing obj) => true;
        public int GetThingIndex(Thing obj) => this.Things.IndexOf(obj);
        public void Execute(Thing obj)
        {
            while (this.IsExecutableBy(obj)) this.RunExecution();
            obj.Dispose();
        }
    }
}
