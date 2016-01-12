# coding=utf-8
__author__ = 'tzq'
import os
import time
import urllib
import urllib2
import tool
import sys
from WebHelper import HttpHelper

reload(sys)
sys.setdefaultencoding('utf-8')


class Test:
    def __init__(self):
        self.siteURL = 'http://localhost:19617/api/WebApi/CommandHandler'
        self.tool = tool.Tool()
        self.HttpHelper = HttpHelper()

    def PostTest(self):
        postdata = urllib.urlencode({
            'controlType': 5,
            'voiceValue': 10,
            'commend': ''
        })
        # 登录教务系统的URL
        req = urllib2.Request(url=self.siteURL, data=postdata)
        print req
        res_data = urllib2.urlopen(req)
        res = res_data.read()
        print res


Test = Test()
Test.PostTest();
