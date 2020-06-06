using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Charonosaurus
{
    public class CharonosaurusInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "Charonosaurus";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                return null;
            }
        }
        public override string Description
        {
            get
            {
                return "Charonosaurus will help you to create unit tests";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("8f471575-841b-486a-bf6c-9876a5f7e718");
            }
        }

        public override string AuthorName
        {
            get
            {
                return "Wojciech Radaczyński";
            }
        }
        public override string AuthorContact
        {
            get
            {
                return "w.radaczynski@gmail.com";
            }
        }
    }
}
