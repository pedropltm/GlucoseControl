const path = require('path')

module.exports = {
    entry: path.resolve(__dirname,'src', 'index.jsx'), // "__dirname" busca o diretório onde está a instrução
    output: {
        path: path.resolve(__dirname, 'dist'),
        filename: 'bundle.js'
    },
    resolve: {
        extensions: ['.js','.jsx'],
    },
    module: {
        rules: [
            {
                test: /\.jsx$/,
                exclude: /node_modules/,
                use: 'babel-loader', // faz a integração entre o babel e o webpack
            }
        ],
    }
};