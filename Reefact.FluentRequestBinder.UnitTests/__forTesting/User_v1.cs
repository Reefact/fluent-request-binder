﻿#region Usings declarations

#endregion

namespace Reefact.FluentRequestBinder.UnitTests.__forTesting {

    internal class User_v1 {

        public Guid Id  { get; set; }
        public int? Age { get; set; }
        // ReSharper disable once MemberHidesStaticFromOuterClass
        public UserName_v1? UserName { get; set; }

    }

}