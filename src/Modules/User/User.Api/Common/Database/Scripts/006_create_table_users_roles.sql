CREATE TABLE IF NOT EXISTS identity.users_roles (
    user_id     UUID NOT NULL,
    role_id     UUID NOT NULL,

    CONSTRAINT pk_users_roles PRIMARY KEY (user_id, role_id),
    CONSTRAINT fk_users_roles_users FOREIGN KEY (user_id) REFERENCES identity.users(id) ON DELETE CASCADE,
    CONSTRAINT fk_users_roles_roles FOREIGN KEY (role_id) REFERENCES identity.roles(id) ON DELETE CASCADE
);