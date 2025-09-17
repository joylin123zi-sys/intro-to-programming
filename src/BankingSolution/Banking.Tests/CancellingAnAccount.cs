using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Tests;
[Trait("Category", "UnitIntegration")]
public class CancellingAnAccount
{
    [Fact]
    public async Task CancellingAnAccountNotifies()
    {
        await Task.Delay(300);
    }
}
