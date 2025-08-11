using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_Initiative_Tracker.Migrations
{
    /// <inheritdoc />
    public partial class CreateEnums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" DO $$
                BEGIN
                  IF NOT EXISTS (SELECT 1 FROM pg_type WHERE typname = 'death_status') THEN
                    CREATE TYPE death_status AS ENUM ('stable', 'alive', 'dying', 'dead');
                  END IF;
                END$$;

                DO $$
                BEGIN
                  IF NOT EXISTS (SELECT 1 FROM pg_type WHERE typname = 'damage_type_category') THEN
                    CREATE TYPE damage_type_category AS ENUM ('resistant', 'vulnerable', 'immune', 'none');
                  END IF;
                END$$;

                DO $$
                BEGIN
                  IF NOT EXISTS (SELECT 1 FROM pg_type WHERE typname = 'skill_type') THEN
                    CREATE TYPE skill_type AS ENUM ('skill', 'tool', 'instrument');
                  END IF;
                END$$;

                DO $$
                BEGIN
                  IF NOT EXISTS (SELECT 1 FROM pg_type WHERE typname = 'action_type') THEN
                    CREATE TYPE action_type AS ENUM ('action', 'bonus_action', 'reaction', 'trait', 'legendary_action', 'lair_action', 'mythical_action');
                  END IF;
                END$$;

                DO $$
                BEGIN
                  IF NOT EXISTS (SELECT 1 FROM pg_type WHERE typname = 'size') THEN
                    CREATE TYPE size AS ENUM ('Tiny', 'Small', 'Medium', 'Large', 'Huge', 'Gargantuan');
                  END IF;
                END$$;

                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"
                DROP TYPE IF EXISTS action_type;
                DROP TYPE IF EXISTS skill_type;
                DROP TYPE IF EXISTS damage_type_category;
                DROP TYPE IF EXISTS death_status;
                DROP TYPE IF EXISTS size;
                ");


        }
    }
}
