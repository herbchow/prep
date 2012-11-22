using System;
using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using prep.gemskata;

namespace prep.specs.gemskata
{
    public class GemSolverCanvasSpecs
    {
        [Subject(typeof(Canvas))]
        public abstract class gem_solver_canvas_concern : Observes<Canvas>
        {
            Establish e = () =>
                              {
                                  sut = new Canvas();
                              };
        }

        public class when_n_exceeds_constraint : gem_solver_canvas_concern
        {
            Because b = () =>
                spec.catch_exception(() => sut.SetDimensions(2^1025,5));

            It should_throw_argument_exception = () =>
            {
                spec.exception_thrown.ShouldBeAn<ArgumentException>();
            };
        }

        public class when_n_is_within_constraint : gem_solver_canvas_concern
        {
            Establish b = () =>
                spec.catch_exception(() => sut.SetDimensions(2^1024,5));

            It should_throw_argument_exception = () =>
            {
                spec.exception_thrown.ShouldBeNull();
            };
        }

       public class when_k_is_too_large : gem_solver_canvas_concern
       {
           Establish b = () =>
               spec.catch_exception(() => sut.SetDimensions(2^1024,6));

           It should_throw_argument_exception = () =>
           {
               spec.exception_thrown.ShouldBeAn<ArgumentException>();
           };
       }

       public class when_k_is_too_small : gem_solver_canvas_concern
       {
           Establish b = () =>
               spec.catch_exception(() => sut.SetDimensions(2^1024,0));

           It should_throw_argument_exception = () =>
           {
               spec.exception_thrown.ShouldBeAn<ArgumentException>();
           };
       }

//1 ≤ T ≤ 100
//0 ≤ N ≤ 1024
//1 ≤ K ≤ 5
    }

    public class GemsSpecs
    {
        [Subject(typeof(GemsSolver))]
        public abstract class gems_solver_concern : Observes<GemsSolver>
        {
            protected static string input =
                "5 " +
"1 2" +
"2 2" +
"3 4" +
"4 3" +
"5 5";

            protected static GemsSolver Solver;
            Establish c = () =>
                              {
                                  Solver = new GemsSolver();
                              };
        };

        public class when_input_is_1_2 : gems_solver_concern
        {
            static int result;

            Because b = () =>
                result = Solver.Solve(1,2);

            It should_return_7 = () =>
                                     {
                                         result.ShouldEqual(7);

                                     };
        }

        public class when_input_is_2_2 : gems_solver_concern
        {
            static int result;

            Because b = () =>
                result = Solver.Solve(2,2);

            It should_return_71 = () =>
            {
                result.ShouldEqual(71);

            };
        }

        public class when_input_is_3_4 : gems_solver_concern
        {
            static int result;

            Because b = () =>
                result = Solver.Solve(3,4);

            It should_return_211351945 = () =>
            {
                result.ShouldEqual(211351945);

            };
        }
    }
}
