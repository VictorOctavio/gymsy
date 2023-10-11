using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class Client
{
    public int IdClient { get; set; }

    public DateTime LastExpiration { get; set; }

    //public bool Inactive { get; set; }

    public int IdPerson { get; set; }

    public int IdTrainingPlan { get; set; }

    public virtual ICollection<DataFisic> DataFisics { get; set; } = new List<DataFisic>();

    public virtual Person IdPersonNavigation { get; set; } = null!;

    public virtual TrainingPlan IdTrainingPlanNavigation { get; set; } = null!;
}
