using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDP_Projekt.Model
{
    public partial class T_FAHRZEUG
    {
        /// <summary>
        /// Gibt an, ob ein Objekt dieser Klasse neu instanziert wurde
        /// </summary>
        public bool isNew
        {
            get { return !(this.FZG_ID > 0); }
        }
    }

    public partial class T_NUTZER
    {
        /// <summary>
        /// Gibt an, ob ein Objekt dieser Klasse neu instanziert wurde
        /// </summary>
        public bool isNew
        {
            get { return !(this.NUT_ID > 0); }
        }
    }

    public partial class TR_FAHRZEUGMARKE
    {
        /// <summary>
        /// Gibt an, ob ein Objekt dieser Klasse neu instanziert wurde
        /// </summary>
        public bool isNew
        {
            get { return !(this.FZM_ID > 0); }
        }
    }

    public partial class TZ_FAHRZEUGTYP
    {
        /// <summary>
        /// Gibt an, ob ein Objekt dieser Klasse neu instanziert wurde
        /// </summary>
        public bool isNew
        {
            get { return !(this.FZT_ID > 0); }
        }
    }

    public partial class TR_MATERIAL
    {
        /// <summary>
        /// Gibt an, ob ein Objekt dieser Klasse neu instanziert wurde
        /// </summary>
        public bool isNew
        {
            get { return !(this.MAT_ID > 0); }
        }
    }

    public partial class TR_ARBEIT
    {
        /// <summary>
        /// Gibt an, ob ein Objekt dieser Klasse neu instanziert wurde
        /// </summary>
        public bool isNew
        {
            get { return !(this.ARB_ID > 0); }
        }
    }
}
