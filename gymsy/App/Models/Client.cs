using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class Client
{
    public int IdClient { get; set; }

    public DateTime LastExpiration { get; set; }

    public int IdPerson { get; set; }

    public int IdTrainingPlan { get; set; }

    public virtual ICollection<ClientAudit> ClientAudits { get; set; } = new List<ClientAudit>();

    public virtual ICollection<DataFisicAudit> DataFisicAudits { get; set; } = new List<DataFisicAudit>();

    public virtual ICollection<DataFisic> DataFisics { get; set; } = new List<DataFisic>();

    public virtual Person IdPersonNavigation { get; set; } = null!;

    public virtual TrainingPlan IdTrainingPlanNavigation { get; set; } = null!;
}
