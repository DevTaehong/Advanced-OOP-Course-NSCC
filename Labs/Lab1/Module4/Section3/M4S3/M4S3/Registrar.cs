using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4S3
{
    class Registrar
    {
        
        List<IGraduate> grads = new List<IGraduate>();

       

        public Registrar(List<IGraduate> grads)
        {
            this.grads = grads;
        }

        public void graduateAll()
        {
            foreach (var grad in grads)
            {
                grad.graduate();
            }
        }
        
    }
}
