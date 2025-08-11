CREATE TABLE IF NOT EXISTS role (
    id serial PRIMARY KEY,
    name varchar(50)
);

CREATE TABLE IF NOT EXISTS app_user (
    id serial PRIMARY KEY,
    name VARCHAR(50),
    role_id INT REFERENCES role (id)
);

CREATE TABLE IF NOT EXISTS campaign (
    id serial PRIMARY KEY,
    name VARCHAR(50),
    description TEXT,
    vtt_link TEXT,
    drive_link TEXT
);

CREATE TABLE IF NOT EXISTS campaign_user (
    campaign_id INT REFERENCES campaign (id),
    user_id INT REFERENCES app_user (id),
    PRIMARY KEY (campaign_id, user_id)
);

CREATE TYPE size AS ENUM ('Tiny', 'Small', 'Medium', 'Large', 'Huge', 'Gargantuan');

CREATE TABLE IF NOT EXISTS creature_type (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50),
    description TEXT
);

CREATE TABLE IF NOT EXISTS creature (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50),
    size size,
    type_id INT REFERENCES creature_type (id),
    ac INT,
    hp INT,
    hp_dice_count INT,
    hp_dice_size INT,
    hp_dice_bonus INT,
    legendary_action_charges INT,
    profiency_bonus INT,
    notes TEXT,
    is_npc BOOLEAN,
    lair_initiative INT,
    initiative_bonus INT,
    owner_user_id INT REFERENCES app_user (id)
);

CREATE TYPE death_status AS ENUM ('stable', 'alive', 'dying', 'dead');

CREATE TABLE IF NOT EXISTS encounter (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50),
    turn_count INT,
    campaign_id INT REFERENCES campaign (id),
    notes TEXT
);

CREATE TABLE IF NOT EXISTS creature_encounter (
    creature_id INT REFERENCES creature (id),
    encounter_id INT REFERENCES encounter (id),
    current_hp INT,
    initiative DECIMAL(5, 2),
    temp_hp INT,
    death_status death_status,
    PRIMARY KEY (creature_id, encounter_id)
);

CREATE TABLE IF NOT EXISTS speed (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50),
    description TEXT
);

CREATE TABLE IF NOT EXISTS creature_speed (
    creature_id INT REFERENCES creature (id),
    speed_id INT REFERENCES speed (id),
    speed_value INT,
    is_hover BOOLEAN,
    PRIMARY KEY (creature_id, speed_id)
);

CREATE TABLE IF NOT EXISTS ability_score_type (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS creature_abillity_scores (
    creature_id INT REFERENCES creature (id),
    ability_score_id INT REFERENCES ability_score_type (id),
    score INT,
    is_saving_throw_proficient BOOLEAN,
    PRIMARY KEY (creature_id, ability_score_id)
);

CREATE TYPE damage_type_category AS ENUM ('resistant', 'vulnerable', 'immune', 'none');

CREATE TABLE IF NOT EXISTS damage_types (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS creature_damage_types (
    creature_id INT REFERENCES creature (id),
    damage_type_id INT REFERENCES damage_types (id),
    damage_type_category damage_type_category,
    PRIMARY KEY (creature_id, damage_type_id)
);

CREATE TABLE IF NOT EXISTS senses (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50),
    description TEXT
);

CREATE TABLE IF NOT EXISTS creature_senses (
    creature_id INT REFERENCES creature (id),
    sense_id INT REFERENCES senses (id),
    distance INT,
    notes TEXT,
    PRIMARY KEY (creature_id, sense_id)
);

CREATE TABLE IF NOT EXISTS languages (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50),
    description TEXT
);

CREATE TABLE IF NOT EXISTS creature_language (
    creature_id INT REFERENCES creature (id),
    language_id INT REFERENCES languages (id),
    notes TEXT,
    PRIMARY KEY (creature_id, language_id)
);

CREATE TYPE skill_type AS ENUM ('skill', 'tool', 'instrument');

CREATE TABLE IF NOT EXISTS skill (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50),
    skill_type skill_type,
    description TEXT
);

CREATE TABLE IF NOT EXISTS creature_skill (
    creature_id INT REFERENCES creature (id),
    skill_id INT REFERENCES skill (id),
    is_profienct BOOLEAN,
    is_expertise BOOLEAN,
    bonus_override INT,
    PRIMARY KEY (creature_id, skill_id)
);

CREATE TABLE IF NOT EXISTS condition (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50),
    description TEXT
);

CREATE TABLE IF NOT EXISTS creature_condition (
    creature_id INT REFERENCES creature (id),
    condition_id INT REFERENCES condition (id),
    condition_length INT,
    PRIMARY KEY (creature_id, condition_id)
);

CREATE TYPE action_type AS ENUM('action', 'bonus_action', 'reaction', 'trait', 'legendary_action', 'lair_action', 'mythical_action');

CREATE TABLE IF NOT EXISTS spell (
    id SERIAL PRIMARY KEY,
    school VARCHAR(50),
    concentration BOOLEAN,
    duration INT
);

CREATE TABLE IF NOT EXISTS action (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50),
    description TEXT,
    action_type action_type,
    recharge VARCHAR,
    reach INT,
    attack_bonus INT,
    range INT,
    area INT,
    save_dc VARCHAR
)

CREATE TABLE IF NOT EXISTS spell_action (
    spell_id INT REFERENCES spell (id),
    action_id INT REFERENCES action (id),
    PRIMARY KEY (spell_id, action_id)
);

CREATE TABLE IF NOT EXISTS creature_action (
    creature_id INT REFERENCES creature (id),
    action_id INT REFERENCES action (id),
    spell_prepared BOOLEAN,
    PRIMARY KEY (creature_id, action_id)
);

CREATE INDEX idx_action_type ON action (action_type);

CREATE INDEX idx_user_owner_creature ON creature (owner_user_id);

CREATE INDEX idx_encounter_death_status ON creature_encounter (death_status);

CREATE INDEX idx_damage_type_category ON creature_damage_types (damage_type_category);

CREATE INDEX idx_skill_type ON skill (skill_type);

CREATE INDEX idx_initiative ON creature_encounter (encounter_id, initiative DESC);