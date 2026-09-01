CREATE TABLE IF NOT EXISTS identity.roles_permissions (
    role_id         UUID NOT NULL,
    permission_id   UUID NOT NULL,

    CONSTRAINT pk_roles_permissions PRIMARY KEY (role_id, permission_id),
    CONSTRAINT fk_roles_permissions_roles FOREIGN KEY (role_id) REFERENCES identity.roles(id) ON DELETE CASCADE,
    CONSTRAINT fk_roles_permissions_permissions FOREIGN KEY (permission_id) REFERENCES identity.permissions(id) ON DELETE CASCADE
);