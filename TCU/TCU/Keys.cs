using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TCU
{
  public class Key
  {
    private bool active;
    private string name;
    private string color;

    public Key(string name)
    {
      this.name = name;
      this.active = false;
      this.color = "Black";
    }

    public void ActivateKey(Key keyToActivate, string keyName)
    {
      keyToActivate.active = true;
      MessageBox.Show("activa");
    }

    public void DeactivateKey(Key keyToDeactivate, string keyName)
    {
      keyToDeactivate.active =false;
      MessageBox.Show("desactiva");
    }
  
  }
}
