<?php
namespace app\api\controller\member;
use app\api\controller\Base;

class Info extends Base{
    function info(){
        return $this->success('SUCCESS',
            \Tinywan\Jwt\JwtToken::getUser(),
        );
    }
}