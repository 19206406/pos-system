CREATE TABLE IF NOT EXISTS identity.users (
    id              UUID NOT NULL DEFAULT gen_random_uuid(),
    full_name       VARCHAR(100) NOT NULL,
    phone_number    VARCHAR(20) NULL,
    "position"      VARCHAR(100) NOT NULL, -- entre comillas: "position" es palabra reservada en el estándar SQL
    email           VARCHAR(150) NOT NULL,
    hash_password   TEXT NULL, -- NULL = usuario creado pero aún sin registrar contraseña
    created_at      TIMESTAMPTZ NOT NULL,
    updated_at      TIMESTAMPTZ NOT NULL,

    CONSTRAINT pk_users PRIMARY KEY (id),
    CONSTRAINT uq_users_email UNIQUE (email)
);