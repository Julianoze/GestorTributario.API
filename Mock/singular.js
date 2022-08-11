'use strict'

module.exports = (req, res, next) => {
  const _send = res.send
  res.send = function (body) {

    try {
      const json = JSON.parse(body)
      if (!Array.isArray(json))
        return _send.call(this, body)

      return _send.call(this, JSON.stringify(json[0]))
    } catch (e) {}
  }
  next()
}