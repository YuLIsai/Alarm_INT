using System;
using System.Collections.Generic;
using System.Text;
using AlarmTech.Model;
namespace AlarmTech.ViewModel
{
   public class Notificacion
    {
        public List<Notificacion_E> Noti { get; set; }

        public Notificacion()
        {
            Noti = new List<Notificacion_E>
            {
                new Notificacion_E
                {
                    Imagen="icon_warning.png",
                    Nombre="Movimiendo detectado",
                    Descripcion="Se detecto movimiento en el hogar",
                    Fecha="02/03/2022 15:30:21"
                },
                new Notificacion_E
                {
                    Imagen="icon_warning.png",
                    Nombre="Movimiendo detectado",
                    Descripcion="Se detecto movimiento en el hogar",
                    Fecha="01/03/2022 12:07:21"
                },
                new Notificacion_E
                {
                    Imagen="icon_warning.png",
                    Nombre="Movimiendo detectado",
                    Descripcion="Se detecto movimiento en el hogar",
                    Fecha="28/03/2022 16:31:21"
                }

            };
        }
        }
}
