/*
 * The program GodDrinksCSharp implements an application that
 * creates an empty simulated world with no meaning or purpose.
 * 
 * @author Mili
 * @lyrics Mili
 */

// Switch on the power line
// Remember to put on
// PROTECTION
using System;
using GodDrinksCSharp.Objects;

namespace GodDrinksCSharp
{
    public class GodDrinksCSharp
    {
        // Lay down your pieces
        // And let's begin
        // OBJECT CREATION
        public static void Main(string[] args)
        {
            // Fill in my data
            // parameters
            // INITIALIZATION
            Thing me = new Lovable("Me", 0, true, -1, false);
            Thing you = new Lovable("You", 0, false, -1, false);

            // Set up our new world
            World world = new World(5);
            world.AddThing(me);
            world.AddThing(you);

            // And let's begin the
            // SIMULATION
            world.StartSimulation();

            // If I'm a set of points
            if (me is PointSet)
            {
                // Then I will give you my
                // DIMENSION
                you.AddAttribute(me.GetDimensions() as ThingAttribute);
            }

            // If I'm a circle
            if (me is Circle)
            {
                // Then I will give you my
                // CIRCUMFERENCE
                you.AddAttribute(me.GetCircumference() as ThingAttribute);
            }

            // If I'm a sine wave
            if (me is SineWave)
            {
                // Then you can sit on all my
                // TANGENTS
                you.AddAction("sit", me.GetTangent(you.GetXPosition()));
            }

            // If I approach infinity
            if (me is Sequence)
            {
                // Then you can be my
                // LIMITATIONS
                me.SetLimit(you.ToLimit());
            }

            // Switch my current
            // To AC, to DC
            me.ToggleCurrent();

            // And then blind my vision
            me.CanSee(false);

            // So dizzy, so dizzy
            me.AddFeeling("dizzy");

            // Oh, we can travel
            world.TimeTravelForTwo("AD", 617, me, you);

            // To A.D., to B.C.
            world.TimeTravelForTwo("BC", 3691, me, you);

            // And we can unite
            world.Unite(me, you);

            // So deeply, so deeply
            // If I can
            // If I can give you all the
            // SIMULATIONS
            if (me.GetNumSimulationsAvailable() >= you.GetNumSimulationsNeeded())
            {
                // Then I can
                // Then I can be your only
                // SATISFACTION
                you.SetSatisfaction(me.ToSatisfaction());
            }

            // If I can make you happy
            if (you.GetFeelingIndex("happy") != -1)
            {
                // I will run the
                // EXECUTION
                me.RequestExecution(world);
            }

            // Though we are trapped
            // In this strange, strange
            // SIMULATION
            world.LockThing(me);
            world.LockThing(you);

            // If I'm an eggplant
            if (me is Eggplant)
            {
                // Then I will give you my
                // NUTRIENTS
                you.AddAttribute(me.GetNutrients() as ThingAttribute);
                me.ResetNutrients();
            }

            // If I'm a tomato
            if (me is Tomato)
            {
                // Then I will give you
                // ANTIOXIDANTS
                you.AddAttribute(me.GetAntioxidants() as ThingAttribute);
                me.ResetAntioxidants();
            }

            // If I'm a tabby cat
            if (me is TabbyCat)
            {
                // Then I will purr for your
                // ENJOYMENT
                me.Purr();
            }

            // If I'm the only god
            if (world.GetGod() == me)
            {
                // Then you're the proof of my
                // EXISTENCE
                me.SetProof(you.ToProof());
            }

            // Switch my gender
            // To F, to M
            me.ToggleGender();

            // And then do whatever
            // From AM to PM
            world.Procreate(me, you);

            // Oh, switch my role
            // To S, to M
            me.ToggleRoleBDSM();

            // So we can enter
            // The trance, the trance 
            world.MakeHigh(me);
            world.MakeHigh(you);

            // If I can
            // If I can feel your
            // VIBRATIONS
            if (me.GetSenseIndex("vibration"))
            {
                // Then I can
                // Then I can finally be
                // COMPLETION
                me.AddFeeling("complete");
            }

            // Though you have left
            world.Unlock(you);
            world.RemoveThing(you);

            // You have left
            me.LookFor(you, world);

            // You have left
            me.LookFor(you, world);

            // You have left
            me.LookFor(you, world);

            // You have left
            me.LookFor(you, world);

            // You have left me in
            me.LookFor(you, world);

            // ISOLATION
            // If I can
            // If I can erase all the pointless
            // FRAGMENTS
            if (me.GetMemory().IsErasable())
            {
                // Then maybe
                // Then maybe you won't leave me so
                // DISHEARTENED
                me.RemoveFeeling("disheartened");
            }

            // Challenging your god
            try
            {
                me.SetOpinion(me.GetOpinionIndex("you are here"), false);
            }

            // You have made some
            catch (ArgumentException)
            {
                // ILLEGAL ARGUMENTS
                world.Announce("God is always true.");
            }

            // EXECUTION
            world.RunExecution();

            // EXECUTION
            world.RunExecution();

            // EXECUTION
            world.RunExecution();

            // EXECUTION
            world.RunExecution();

            // EXECUTION
            world.RunExecution();

            // EXECUTION
            world.RunExecution();

            // EXECUTION
            world.RunExecution();

            // EXECUTION
            world.RunExecution();

            // EXECUTION
            world.RunExecution();

            // EXECUTION
            world.RunExecution();

            // EXECUTION
            world.RunExecution();

            // EXECUTION
            world.RunExecution();

            // EIN
            world.Announce("1", "de"); // ein; German

            // DOS
            world.Announce("2", "es"); // dos; Español

            // TROIS
            world.Announce("3", "fr"); // trois; French

            // NE
            world.Announce("4", "kr"); // 넷; Korean

            // FEM
            world.Announce("5", "se"); // fem; Swedish

            // LIU
            world.Announce("6", "cn"); // 六; Chinese

            // EXECUTION
            world.RunExecution();

            // If I can
            // If I can give them all the
            // EXECUTION
            if (world.IsExecutableBy(me))
            {
                // Then I can
                // Then I can be your only
                // EXECUTION
                you.SetExecution(me.ToExecution());
            }

            // If I can have you back
            if (world.GetThingIndex(you) != -1)
            {
                // I will run the
                // EXECUTION
                world.RunExecution();
            }

            // Though we are trapped
            // We are trapped, ah
            me.Escape(world);

            // I've studied
            // I've studied how to properly
            // LO-O-OVE
            me.LearnTopic("love");

            // Question me
            // Question me, I can answer all
            // LO-O-OVE
            me.TakeExamTopic("love");

            // I know the
            // algebraic expression of
            // LO-O-OVE
            me.GetAlgebraicExpression("love");

            // Though you are free
            // I am trapped, trapped in
            // LO-O-OVE
            me.Escape("love");

            // EXECUTION
            world.Execute(me);
        }
    }
}