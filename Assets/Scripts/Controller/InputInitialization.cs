using Interfeices;

namespace Controller
{
    public class InputInitialization : IInitialization
    {
        private IUserInputProxy _pcUserInputHorizontal;
        private IUserInputProxy _pcUserInputVertical;

        public InputInitialization()
        {
            _pcUserInputHorizontal = new PCInputHorizontal();
            _pcUserInputVertical = new PCIInputVertical();
        }
        public void Initialization()
        {
            
        }

        public (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) GetInput()
        {
            (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) result = (_pcUserInputHorizontal,
                _pcUserInputVertical);
            return result;
        }
    }
}