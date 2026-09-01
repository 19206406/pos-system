CREATE TABLE IF NOT EXISTS identity.permissions (
    id                      UUID NOT NULL DEFAULT gen_random_uuid(),
    permission_name         VARCHAR(50) NOT NULL,
    permission_description  VARCHAR(250) NOT NULL,
    identifier              VARCHAR(50) NOT NULL,

    CONSTRAINT pk_permissions PRIMARY KEY (id),
    CONSTRAINT uq_permissions_identifier UNIQUE (identifier)
);