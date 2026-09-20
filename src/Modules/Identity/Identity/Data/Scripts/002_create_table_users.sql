CREATE TABLE IF NOT EXISTS identity.users (
    id              UUID NOT NULL DEFAULT gen_random_uuid(),
    full_name       VARCHAR(100) NOT NULL,
    phone_number    VARCHAR(20) NULL,
    job_title       VARCHAR(100) NOT NULL,
    email           VARCHAR(150) NOT NULL,
    is_active       BOOLEAN DEFAULT true, 
    hash_password   TEXT NULL, 
    created_at      TIMESTAMPTZ NOT NULL,
    updated_at      TIMESTAMPTZ NOT NULL,

    CONSTRAINT pk_users PRIMARY KEY (id),
    CONSTRAINT uq_users_email UNIQUE (email)
);