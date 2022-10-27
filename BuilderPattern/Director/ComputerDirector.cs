using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.Director
{
    public class ComputerDirector
    {
        private ComputerBuilder _builder = null;

        public ComputerDirector(ComputerBuilder builder)
        {
            this._builder = builder;
        }

        public Computer AssembleComputer()
        {
            _builder.BuildCPU();
            _builder.BuildDisk();
            _builder.BuildMemory();
            _builder.BuildGraphicsCard();
            _builder.BuildMainBoard();
            return _builder.CreateComputer();
        }
    }
}
