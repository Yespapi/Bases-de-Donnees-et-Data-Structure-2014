using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace MessageBoard.Data
{
    public  class MessageBoardMigrationsConfiguration  :DbMigrationsConfiguration<MessageBoardContext>
    {
        public MessageBoardMigrationsConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled =true;
        }
        protected override void Seed(MessageBoardContext context)
        {
            base.Seed(context);
        } 
    }
}
