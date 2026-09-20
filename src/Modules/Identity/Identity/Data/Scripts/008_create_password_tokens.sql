CREATE TABLE IF NOT EXISTS identity.password_tokens(
	id			UUID NOT NULL DEAFAULT gen_random_uuid(), 
	user_id		UUID NOT NULL, 
	token_hash	VARCHAR(255) NOT NULL, 
	token_type	VARCHAR(20) NOT NULL, 
	expires_at	TIMESTAMPTZ NOT NULL, 
	used_at		TIMESTAMPTZ NULL, 
	created_at	TIMESTAMPTZ NOT NULL DEFAULT now(), 


