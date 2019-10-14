const https = require('https');
const BRANCH_FILE = './commit.txt';
const UNIT_TEST_RESULT_PATH = './results.json';

const unitTest = require(UNIT_TEST_RESULT_PATH);
const lineReader = require('line-reader');

const getCommitId = (filePath) => {
    return new Promise((resolve, reject) => {
        lineReader.eachLine(filePath, line => {
            resolve(line);
        }) 
    });
};

const postData = async () => {
    const commitId = await getCommitId(BRANCH_FILE);
    const params = {
        commitId,
        unitTest
    };
    return params;
};

const sendReportData = async () => {
  const data = await postData();
  const options = {
    hostname: 'd3s6yky9vet5yl.cloudfront.net',
    path: '/assessments/report',
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
      'Content-Length': Buffer.byteLength(JSON.stringify(data))
    }
  };
  
  const req = https.request(options, (res) => {}); 
  
  req.write(JSON.stringify(data));
  req.end();
};

sendReportData();
  
 
