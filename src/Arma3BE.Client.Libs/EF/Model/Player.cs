//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using Arma3BEClient.Libs.Core;

namespace Arma3BEClient.Libs.EF.Model
{
    public partial class Player : PlayerDto
    {
        public Player()
        {
            this.Notes = new HashSet<Note>();
            this.PlayerHistory = new HashSet<PlayerHistory>();
            // this.Sessions = new HashSet<Sessions>();
        }

        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Ban> Bans { get; set; }
        public virtual ICollection<PlayerHistory> PlayerHistory { get; set; }
    }
}