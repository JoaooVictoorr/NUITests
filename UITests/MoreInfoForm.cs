using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests
{
    class MoreInfoForm : General
    {
        public class MoreInfoFormData
        {
            public string nome;
            public string email;
            public string empresa;
            public string cargo;
            public string telefone;
            public string cidade;
            public string estado;
        }

        public MoreInfoForm FillFields(MoreInfoFormData data)
        {
            Input.InformValue("Nome", data.nome);
            Input.InformValue("Email", data.email);
            Input.InformValue("Empresa", data.empresa);
            Input.InformValue("Cargo", data.cargo);
            Input.InformValue("Telefone", data.telefone);
            Input.InformValue("Cidade", data.cidade);
            Input.InformValue("Estado", data.estado);
            return this;
        }
    }
}
