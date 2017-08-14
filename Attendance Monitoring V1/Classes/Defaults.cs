using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AMS.Classes
{
    class Defaults
    {
        public static void SetDefaultUser()
        {
            string query = "INSERT INTO Users(church_id,password,fname,lname,privilege,locale_id,is_deleted,is_approve)"+
                "SELECT def_church_id, def_password, def_fname, def_lname, def_privilege, def_locale_id, def_is_deleted, def_is_approve FROM def_user WHERE NOT EXISTS (SELECT user_id FROM Users WHERE Users.user_id=def_user.def_user_id)";

            using (var cmd = new SqlCommand(query, Utilities.con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public static void SetDefaultCommittees()
        {
            string query = "INSERT INTO Committee(committee_name,committee_code,is_deleted)" +
                "SELECT temp_committee_name, temp_committee_code, is_deleted FROM def_committee WHERE NOT EXISTS (SELECT committee_id FROM Committee WHERE Committee.committee_id=def_committee.temp_committee_id)";

            using (var cmd = new SqlCommand(query, Utilities.con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
