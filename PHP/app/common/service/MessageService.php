<?php

namespace app\common\service;
use Webman\RedisQueue\Client;
class MessageService
{
    public function World($data){
        Client::send('word-message',$data);
    }
}