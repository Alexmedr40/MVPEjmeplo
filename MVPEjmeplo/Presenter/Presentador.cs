using MVPEjmeplo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPEjmeplo.Model;

namespace MVPEjmeplo.Presenter
{
    public class Presentador
    {
        private readonly IVista _view;
        private readonly Modelo _model;

        public Presentador(IVista view, Modelo model)
        {
            _view = view;
            _model = model;
            _view.ButtonClick += OnButtonClick;
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            _view.SetMessage(_model.GetMessage());
        }
    }
}
