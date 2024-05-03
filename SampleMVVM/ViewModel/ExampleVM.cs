using SampleMVVM.Infastructure;
using SampleMVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleMVVM.ViewModel
{
    internal class ExampleVM : BaseVM
    {
        #region ПОЛЯ

        private readonly BaseVM _baseVM;

        #endregion

        #region СВОЙСТВА

        private string _property;
        public string Property { get => _property; set => Set(ref _property, value); }

        #endregion

        #region КОМАНДЫ

        public ICommand GetCommand() => new LambdaCommand(OnCommand, CanCommand);

        private bool CanCommand(object p) => true;

        private void OnCommand(object p)
        {

        }

        #endregion


        public ExampleVM(BaseVM baseVM)
        {
            
        }
    }
}
