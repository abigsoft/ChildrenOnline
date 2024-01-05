<?php

namespace app\admin\controller;

use app\common\controller\BaseController;
use app\common\model\ConfigModel;
use support\Request;
use Webman\Event\Event;
class Index extends BaseController
{
    function index(Request $request){
        //Event::emit('throw.auth', ['a'=>1]);
    }
}