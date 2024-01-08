<?php

namespace app\api\controller;

use app\common\controller\BaseController;
use Tinywan\Jwt\JwtToken;

class Login extends BaseController
{
    protected function makeToken($uid,$name = ''): string
    {
        $user = [
            'id'  => $uid,
            'name'  => $name,
            'client' => JwtToken::TOKEN_CLIENT_MOBILE
        ];
        /**
         * "token_type": "Bearer",
         * "expires_in": 36000,
         * "access_token": "eyJ0eXAiOiJAUR-Gqtnk9LUPO8IDrLK7tjCwQZ7CI...",
         * "refresh_token": "eyJ0eXAiOiJIEGkKprvcccccQvsTJaOyNy8yweZc..."
         */
        return JwtToken::generateToken($user)['access_token'];
    }

    function account(){

    }

    protected function saveUser($uid, $user_info): void
    {
        \support\Redis::set('user_info_' . $uid, $user_info);
    }
}