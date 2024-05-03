﻿using SampleMVVM.Infastructure;
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

        private readonly MainVM _mvvm;

        #endregion

        #region СВОЙСТВА

        private string _firstLabel = "Hello world1";
        public string FirstLabel { get => _firstLabel; set => Set(ref _firstLabel, value); }

        #endregion

        #region КОМАНДЫ

        public ICommand GetCommand() => new LambdaCommand(OnCommand, CanCommand);

        private bool CanCommand(object p) => true;

        private void OnCommand(object p)
        {
            _mvvm.Content = new ExampleVM2(_mvvm);
        }

        #endregion


        public ExampleVM(MainVM mvvm)
        {
            _mvvm = mvvm;
        }
    }
}
