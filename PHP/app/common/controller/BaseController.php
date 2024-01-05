<?php

namespace app\common\controller;

use support\Request;

abstract class BaseController
{
    protected $request;
    protected $successCode;
    protected $errorCode;

    // 初始化
    protected function initialize(Request $request)
    {
        $this->request     = $request;
        $this->successCode = config('my.successCode');
        $this->errorCode = config('my.errorCode');

        buildConfig();
        buildDict();
    }

    protected function success($message = '操作成功',$data = []): \support\Response
    {
        return json([
            'status'=>config('my.successCode'),
            'msg'=> $message,
            'data' => $data
        ]);
    }

    protected function error($message = '操作失败',$data = []): \support\Response
    {
        return json([
            'status'=>config('my.errorCode'),
            'msg'=> $message,
            'data' => $data
        ]);
    }
}