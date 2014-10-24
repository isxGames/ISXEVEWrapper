using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class Overview : LavishScriptObject
    {
        public Overview() : base(LavishScript.Objects.GetObject("Overview"))
        {
        }

        #region LavishScript Members

        public Entity SelectedItem
        {
            get { return new Entity(GetMember("SelectedItem")); }
        }

        #endregion

        #region LavishScript Methods

        public bool ClearSelectedItem()
        {
            return ExecuteMethod("ClearSelectedItem");
        }

        #endregion
    }
}
