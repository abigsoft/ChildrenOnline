<?php

namespace app\queue\redis;

use GatewayWorker\Lib\Gateway;
use Webman\Event\Event;
use Webman\RedisQueue\Consumer;

class WordMessage implements Consumer
{
    // 要消费的队列名
    public string $queue = 'word-message';
    // 消费
    public function consume($data): void
    {
        try {
            if(is_string($data)){
                Gateway::sendToAll($data);
            }else{
                Gateway::sendToAll(json_encode($data));
            }
        } catch (\Exception $e) {
            Event::emit('throw.chat',$e);
        }
    }
}