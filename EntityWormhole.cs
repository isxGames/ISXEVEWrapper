using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class EntityWormhole : Entity
    {
        public EntityWormhole(LavishScriptObject copy) : base(copy)
        {
            
        }

        private int? _age;
        /// <summary>
        /// ISXEVE-20131219.0007 - December 24, 2013:
        /// Returns -10 on error.
        /// </summary>
        public int Age
        {
            get
            {
                if (_age == null)
                    _age = this.GetInt("Age");

                return _age.Value;
            }
        }

        private float? _size;
        /// <summary>
        /// ISXEVE-20131219.0007 - December 24, 2013:
        /// Returns -10.0 on error.
        /// </summary>
        public float Size
        {
            get
            {
                if (_size == null)
                    _size = this.GetFloat("Float");

                return _size.Value;
            }
        }

        private int? _class;
        /// <summary>
        /// ISXEVE-20131219.0007 - December 24, 2013:
        /// Returns -10 on error.
        /// </summary>
        public int Class
        {
            get
            {
                if (_class == null)
                    _class = this.GetInt("Class");

                return _class.Value;
            }
        }

        public bool EnterWormhole()
        {
            return ExecuteMethod("EnterWormhole");
        }
    }
}
