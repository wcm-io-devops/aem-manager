using System;
using System.Collections.Generic;
using System.Text;

namespace AEMManager {

  public enum AemInstanceType {

    AEM54,

    AEM55

  }

  public static class AemInstanceTypeUtil {

    public static string GetLabel(AemInstanceType pAemInstanceType) {
      if (pAemInstanceType == AemInstanceType.AEM54) {
        return "AEM 5.4 and below";
      }
      else if (pAemInstanceType == AemInstanceType.AEM55) {
        return "AEM 5.5, AEM 6 and higher";
      }
      // fallback
      return pAemInstanceType.ToString();
    }

  }

}
