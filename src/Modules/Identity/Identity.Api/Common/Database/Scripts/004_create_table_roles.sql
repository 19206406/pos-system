CREATE TABLE IF NOT EXISTS identity.roles (
    id                  UUID NOT NULL DEFAULT gen_random_uuid(),
    role_name           VARCHAR(50) NOT NULL,
    role_description    VARCHAR(250) NOT NULL,

    CONSTRAINT pk_roles PRIMARY KEY (id),
    CONSTRAINT uq_roles_role_name UNIQUE (role_name)
);