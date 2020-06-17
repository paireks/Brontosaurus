using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Brontosaurus
{
    public class BrontosaurusInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "Brontosaurus";
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
                return "Brontosaurus will help you to create unit tests inside Grasshopper";
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
                return "Wojciech Radaczynski";
            }
        }
        public override string AuthorContact
        {
            get
            {
                return "w.radaczynski@gmail.com";
            }
        }

        public override string Version
        {
            get
            {
                return "1.0.0.0";
            }
        }
    }
}
