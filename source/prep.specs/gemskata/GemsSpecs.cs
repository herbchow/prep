using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;

namespace prep.gemskata
{
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
