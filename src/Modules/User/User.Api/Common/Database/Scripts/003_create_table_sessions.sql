CREATE TABLE IF NOT EXISTS identity.sessions (
    id              UUID NOT NULL DEFAULT gen_random_uuid(),
    user_id         UUID NOT NULL,
    token_hash      VARCHAR(255) NOT NULL,
    device_info     VARCHAR(50) NULL,
    ip_address      VARCHAR(50) NULL,
    created_at      TIMESTAMPTZ NOT NULL,
    expires_at      TIMESTAMPTZ NOT NULL,
    revoked_at      TIMESTAMPTZ NULL,
    replaced_by_id  UUID NULL,

    CONSTRAINT pk_sessions PRIMARY KEY (id),
    CONSTRAINT uq_sessions_token_hash UNIQUE (token_hash),
    CONSTRAINT fk_sessions_users FOREIGN KEY (user_id) REFERENCES identity.users(id) ON DELETE CASCADE,
    CONSTRAINT fk_sessions_replaced_by FOREIGN KEY (replaced_by_id) REFERENCES identity.sessions(id)
);

CREATE INDEX IF NOT EXISTS idx_sessions_user_id ON identity.sessions(user_id);
CREATE INDEX IF NOT EXISTS idx_sessions_token_hash ON identity.sessions(token_hash);