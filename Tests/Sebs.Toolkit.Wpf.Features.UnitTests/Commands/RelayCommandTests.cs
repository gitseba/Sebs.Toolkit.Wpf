using FluentAssertions;
using Sebs.Toolkit.Wpf.Features.Commands;

namespace Sebs.Toolkit.Wpf.Features.UnitTests
{
    public class RelayCommandTests
    {

        private static IEnumerable<object[]> Arguments
        {
            get
            {
                /*First Test*/
                yield return new object[]
                {
                    null, /*arg1*/
                    null, /*arg2*/
                };
                /*Second Test*/
                yield return new object[]
                {
                    null, /*arg1*/
                    null, /*arg2*/
                };
            }
        }

        [Fact]
        public void RelayCommand_CtorDoesNotAllowNull()
        {
            Action action = () =>
            {
                _ = new RelayCommand(null);
            };

            action
                .Should()
                .Throw<ArgumentNullException>();
        }

        [Fact]
        public void RelayCommand_CanExecute_ReturnsTrue()
        {
            Action<object> action = (o) => { };

            RelayCommand relayCommand = new RelayCommand(action);

            relayCommand.CanExecute(action).Should().BeTrue();
        }

        [Fact(Timeout = 100)]
        public async Task RelayCommand_Execute_Callback()
        {
            string parameter = "Command Parameter";
            var tcs = new TaskCompletionSource<object>();

            async void action(object o)
            {
                await Task.Delay(10);
                tcs.SetResult(o);
            }

            RelayCommand relayCommand = new RelayCommand(action);

            relayCommand.Execute(parameter);

            var result = await tcs.Task;
            result.Should().Be(parameter);
        }
    }
}