using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal abstract class ConsoleMenu : MenuItem
    {
        protected List<MenuItem> _StudentItems = new List<MenuItem>();
        public bool IsActive { get; set; }
        public abstract void CreateMenu();
        public override string MenuText()
        {
            throw new NotImplementedException();
        }

        public override void Select()
        {
            IsActive = true;
            do
            {
                CreateMenu();
                string output = $"{MenuText()}{Environment.NewLine}";
                int selection = ConsoleHelpers.GetIntegerInRange(1, _StudentItems.Count, this.ToString()) - 1;
                _StudentItems[selection].Select();
            } while (IsActive);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(MenuText());
            for (int i = 0; i < _StudentItems.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {_StudentItems[i].MenuText()}");
            }
            return sb.ToString();
        }
    }
}
