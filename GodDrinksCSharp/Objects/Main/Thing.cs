using System;
using System.Collections.Generic;

namespace GodDrinksCSharp.Objects
{
    public class Thing : IDisposable
    {
        public string CurrentExecutable { get; set; }
        public Memory Memory { get; set; }
        public bool IsHigh { get; set; }
        public string BDSMRole { get; set; }
        public string Gender { get; set; }
        public Proof Proof { get; set; }
        public string Antioxidants { get; set; }
        public string Nutrients { get; set; }
        public bool IsLocked { get; set; }
        public (string, uint) TimePeriod { get; set; }
        public bool HasSight { get; set; }
        public string Current { get; set; }
        public ulong Limit { get; set; }
        public Satisfaction CurrentSatisfaction { get; set; }
        public (int, int, int) Dimensions { get; set; }
        public Dictionary<int, bool> NewOpinions { get; set; }
        public List<string> CurrentOpinions { get; set; }
        public Dictionary<string, Tangent> Actions { get; set; }
        public List<ThingAttribute> Attributes { get; set; }
        public List<string> Feelings { get; set; }
        public List<string> Senses { get; set; }

        public Thing()
        {
            this.Dimensions = (1, 1, 1);
            this.NewOpinions = new Dictionary<int, bool>();
            this.Actions = new Dictionary<string, Tangent>();
            this.Attributes = new List<ThingAttribute>();
            this.Feelings = new List<string>();
            this.Senses = new List<string>();
            this.CurrentOpinions = new List<string>();
            this.Memory = new Memory();
        }

        public void AddAttribute(ThingAttribute attribute) => this.Attributes.Add(attribute);
        public ThingAttribute GetDimensions() => new ThingAttribute();
        public ThingAttribute GetCircumference() => new ThingAttribute();
        public void AddAction(string action_name, Tangent tangent) => this.Actions.Add(action_name, tangent);
        public Tangent GetTangent(int x_position) => new Tangent(x_position);
        public int GetXPosition() => this.Dimensions.Item1;
        public void SetLimit(ulong limit) => this.Limit = limit;
        public ulong ToLimit() => this.Limit;
        public void ToggleCurrent() => this.Current = this.Current switch
        {
            "AC" => "DC",
            "DC" => "AC",
            _ => "AC"
        };
        public void CanSee(bool can_see) => this.HasSight = can_see;
        public void AddFeeling(string name) => this.Feelings.Add(name);
        public int GetNumSimulationsAvailable() => 1;
        public int GetNumSimulationsNeeded() => 1;
        public void SetSatisfaction(Satisfaction sat) => this.CurrentSatisfaction = sat;
        public Satisfaction ToSatisfaction() => new Satisfaction()
        {
            SatisfactionInstance = typeof(Thing),
            SatisfactionType = typeof(Thing).Name
        };
        public int GetFeelingIndex(string key) => this.Feelings.IndexOf(key);
        public bool RequestExecution(World obj) => true;
        public ThingAttribute GetNutrients() => new ThingAttribute();
        public void ResetNutrients() => this.Nutrients = "None";
        public ThingAttribute GetAntioxidants() => new ThingAttribute();
        public void ResetAntioxidants() => this.Antioxidants = "None";
        public void Purr() => Console.WriteLine("Purr");
        public void SetProof(Proof proof) => this.Proof = proof;
        public Proof ToProof() => new Proof()
        {
            ValidatedBy = this
        };
        public void ToggleGender() => this.Gender = this.Gender switch
        {
            "M" => "F",
            "F" => "M",
            _ => "M"
        };
        public void ToggleRoleBDSM() => this.BDSMRole = this.BDSMRole switch
        {
            "S" => "M",
            "M" => "S",
            _ => "S"
        };
        public bool GetSenseIndex(string sense) => (this.Senses.IndexOf(sense) != -1);
        public bool LookFor(Thing obj, World world) => world.Things.Contains(obj);
        public Memory GetMemory() => this.Memory;
        public void RemoveFeeling(string name) => this.Feelings.Remove(name);
        public void SetOpinion(int index, bool god)
        {
            if (!god) throw new ArgumentException("GOD IS ALWAYS TRUE");
            this.NewOpinions.Add(index, god);
        }
        public int GetOpinionIndex(string name) => this.CurrentOpinions.IndexOf(name);
        public void SetExecution(string exe_name) => this.CurrentExecutable = exe_name;
        public string ToExecution() => typeof(Thing).Name;
        public bool Escape(World obj) => false;
        public bool Escape(string obj) => false;
        public void LearnTopic(string topic) => this.Memory.KnownTopics.Add(topic);
        public void TakeExamTopic(string topic) => this.Memory.TakeExam(topic);
        public string GetAlgebraicExpression(string thing) => $"{thing} +/- 2b * (a/y)";
        public void Dispose() => GC.Collect();
    }
}
